App({
  onLaunch(options) {
    console.log('App Launch', options);
    console.log('getSystemInfoSync', dd.getSystemInfoSync());
    console.log('SDKVersion', dd.SDKVersion);
  },
  async onShow() {
    console.log('App Show');
    my.showNavigationBarLoading();
    var getPaddingProjectCount = 0;
    await my.httpRequest({
      url: this.globalData.appurl + '/project/getPaddingProjectCount',
      method: 'GET',
      data: {
        from: '支付宝',
        production: 'AlipayJSAPI',
      },
      headers: {
        'content-type': 'application/json'  //默认值
      },
      dataType: 'json',
      success: function (res) {
        getPaddingProjectCount = res.data;
      },
      fail: function (res) {
        my.alert({ content: 'fail' });
      },
      complete: function (res) {
        my.hideLoading();
      }
    });

    if (getPaddingProjectCount > 0) {
      my.setTabBarBadge({
        index: 0,
        text: getPaddingProjectCount
      });
    }

    my.hideNavigationBarLoading();
  },
  onHide() {
    console.log('App Hide');
  },
  globalData: {
    hasLogin: false,
    appurl: 'http://ajcc.vaiwan.com',
    ERROR_MSG_CantConnect: '无法访问服务器：http://ajcc.vaiwan.com'
  },
  onTabItemTap(item) {
    my.setTabBarBadge({
      index: 0,
      text: '12'
    });
  },
  // Load StepArray，加载项目列表过滤条件
  async loadStepArray() {
    // 过滤条件以数据库为准，参见表：db.project_step
    // 可随意配置项目的不同阶段    
    /* 
      - 数据结构定义：-----------------------------------------------------
      stepArray.original_array = {}; // 原始的数据库记录
      stepArray.content_array = {};  // 用于界面下拉列表显示的文本数组
      stepArray.project_count = n;   // 所有项目的数量
      -------------------------------------------------------------------
    */
    var stepArray = {};
    stepArray.content_array = ['所有项目'];
    stepArray.project_count = 0;

    await my.httpRequest({
      url: this.globalData.appurl + '/projectStep/getProjectStepWithCount',
      method: 'GET',
      data: {},
      headers: { 'content-type': 'application/json' },
      dataType: 'json',
      success: function (res) {
        stepArray.original_array = res.data;

        res.data.forEach(item => {
          var tempCount = "0";
          if (item.project_count != null) {
            tempCount = item.project_count;
            stepArray.project_count += item.project_count;
          }

          if (tempCount != "0") {
            stepArray.content_array.push(item.step_content + '(' + tempCount + ')');
          } else {
            stepArray.content_array.push(item.step_content);
          }
        });
      },
      fail: function (res) {
        my.alert({ content: this.globalData.ERROR_MSG_CantConnect });
      },
      complete: function (res) {
      }
    });
    stepArray.original_array.push({ 'step_content': '所有项目', 'step_thumb': '', 'step_index': -1, 'project_count': stepArray.project_count });
    if (stepArray.project_count > 0) {
      stepArray.content_array[0] = "所有项目(" + stepArray.project_count + ")";
    }

    return stepArray;
  },
  // Load Projects，加载项目列表
  async loadProjectWithStep(step_index, fromPage) {
    console.log("step_index:" + step_index);
    // 可以根据不同项目加载
    // 默认加载所有项目，考虑到实际项目数量，暂不分页
    // this.setData({ list: [] });
    // const tempProjects = this.data.list;
    var projectList = [];

    await my.httpRequest({
      url: this.globalData.appurl + '/project/getProjectListWithStep?step_index=' + step_index,
      method: 'GET',
      data: {},
      headers: { 'content-type': 'application/json' },
      dataType: 'json',
      success: function (res) {
        res.data.forEach(item => {
          var mainTitle;    // 主标题
          var subTitle;     // 副标题
          var secTitle;     // 第三标题
          var thumb;        // 缩略图
          var newItem = {}; // 菜单

          mainTitle = item.project.project_name;
          thumb = item.projectStep != null ? item.projectStep.step_thumb : "Icon_Default.png";
          newItem.right = new Array();
          if (fromPage == "paddingcode") {  // 待审批授权
            newItem.right.push({ 'type': 'other', 'text': '审批通过' });
            newItem.right.push({ 'type': 'delete', 'text': '审批拒绝' });

            subTitle = "合同日期：" + item.project.sign_date + "，实施人员：" + item.employee.name;
            secTitle = "当前进度：" + item.projectStep.step_content;
          } else {  // 所有羡慕列表
            newItem.right.push({ 'type': 'other', 'text': '查看详情' });

            subTitle = "合同日期：" + item.project.sign_date;//"" + ;
            secTitle = "当前进度：" + (item.projectStep != null ? item.projectStep.step_content : "");
          }

          newItem.upperSubtitle = subTitle;
          newItem.licenceTo = secTitle;
          newItem.content = mainTitle;
          newItem.thumb = thumb;
          newItem.id = item.project.id;

          projectList.push(newItem);
        });
      },
      fail: function (res) {
        my.alert({ content: this.globalData.ERROR_MSG_CantConnect });
      },
      complete: function (res) { }
    });

    return projectList;
  },
  // getProjectDetailById
  async getProjectDetailById(projectId) {
    var projectItem = {};
    await my.httpRequest({
      url: this.globalData.appurl + '/project/getProjectDetailById?projectId=' + projectId,
      method: 'GET',
      data: {},
      headers: { 'content-type': 'application/json' },
      dataType: 'json',
      success: function (res) {
        projectItem = res.data;
        // res.data.forEach(item => {});
      },
      fail: function (res) {
        my.alert({ content: this.globalData.ERROR_MSG_CantConnect });
      },
      complete: function (res) {
      }
    });
    return projectItem;
  },
  // getAllEmployee
  async getAllEmployee() {
    var tempEmployeeList = {};
    await my.httpRequest({
      url: this.globalData.appurl + '/employees/findAll',
      method: 'GET',
      data: {},
      headers: { 'content-type': 'application/json' },
      dataType: 'json',
      success: function (res) {
        tempEmployeeList = res.data;
      },
      fail: function (res) {
        my.alert({ content: app.globalData.ERROR_MSG_CantConnect });
      },
      complete: function (res) {
        my.hideLoading();
      }
    });
    return tempEmployeeList;
  }
});
