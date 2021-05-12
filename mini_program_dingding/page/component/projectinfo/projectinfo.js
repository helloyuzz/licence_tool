let app = getApp();
Page({
  data: {
    activeTab: 0,
    param_pid: -1,
    param_pname: '',
    btnVisable: 'none',
    tabs: [
      { title: '授权信息' },
      { title: '当前进度' },
      { title: '更多...' },
    ],
    stepActiveIndex: 3,
    stepItems: [{
      title: '[等待授权]',
      description: '已完成',
    }, {
      title: '[项目实施]',
      description: '已完成',
    }, {
      title: '项目验收',
      description: '进行中',
    }, {
      title: '维保中',
      description: 'N/A',
    }, {
      title: '结项',
      description: 'N/A',
    }],
    value: 8,
    content: '',
    project_name: '',
    sign_date: '',
    finish_date: '',
    emplyee_id: '',
    employee_name: '',
    current_progress: '',
    unique_code: '',
    project_desc: '',
    licence_code: '',
  },
  async onLoad(param) {
    console.log(param.id);
    console.log(param.project_name);
    console.log(param.is_Padding);
    my.showLoading({ content: "加载中..." });

    this.setData({ param_pid: param.id, param_pname: param.project_name });

    var projectId = param.id;
    var projectName = param.project_name;

    this.setData({ content: projectName });
    dd.setNavigationBar({
      title: projectName
    });

    // LoadProjectDetailById
    var projectItem = await app.getProjectDetailById(projectId);
    if (projectItem != null) {
      this.setData({ project_name: projectItem.project.project_name });
      this.setData({ unique_code: projectItem.project.unique_code });
      this.setData({ sign_date: projectItem.project.sign_date });
      this.setData({ finish_date: projectItem.project.finish_date });
      this.setData({ employee_name: projectItem.employee.name });
      this.setData({ licence_code: projectItem.project.licence_code });
      this.setData({ project_desc: projectItem.project.project_desc });
      this.setData({ stepActiveIndex: projectItem.project.step_index });

      // 判断是否等待授权，是：显示授权按钮，否：不显示按钮
      if (projectItem.project.step_index == app.ProjectStep.step_waitting_licence) {
        this.setData({ btnVisable: 'block' });
      }
    }

    // Load ProjectStepArray
    this.setData({ stepItems: [] });
    var tempStepArray = [];
    var tempActiveIndex = this.data.stepActiveIndex;
    var stepArray = await app.loadStepArray();
    if (stepArray != null) {
      stepArray.original_array.forEach(item => {
        if (item.step_index >= 0) {
          var tempDescription = "未开始";
          if (item.step_index < tempActiveIndex) {
            tempDescription = "已完成";
          } else if (item.step_index == tempActiveIndex) {
            tempDescription = "正在进行...";
          }
          tempStepArray.push({ 'title': item.step_content, 'description': tempDescription });
        }
      });
      this.setData({ stepItems: tempStepArray });
    }

    if (param.is_Padding == "true") {  // 从待审批跳转过来
      this.setData({ activeTab: 1 });
    }
    my.hideLoading();
  },
  callBackFn(value) {
    console.log(value);
  },
  modifyValue() {
    this.setData({
      value: this.data.value + 1,
    });
  },
  handleChange(index) {
    this.setData({
      activeTab: index,
    });
  },
  onChange(index) {
    console.log('onChange', index);
    this.setData({
      activeTab: index,
    });
  },
  handleTabClick({ index }) {
    this.setData({
      activeTab: index,
    });
  },
  handleTabChange({ index }) {
    this.setData({
      activeTab: index,
    });
  },
  async agree_licence() {
    var confirmResult = false;
    await my.confirm({
      title: '温馨提示',
      content: '是否通过该申请？',
      confirmButtonText: '确定',
      cancelButtonText: '取消',
      success: (result) => {
        confirmResult = result.confirm;
        // my.alert({
        //   title: `${result.confirm}`,
        // });
      },
    });
    if (confirmResult == true) {
      var saveResult = false;

      saveResult = await app.changeProjectStepById(this.data.param_pid, app.ProjectStep.step_agree_licence);
      if (saveResult == true) {
        await app.loadPaddingProjectCount();  // 更新统计数量

        await my.alert({ title: '审批成功' });
        my.reLaunch({ url: '/page/component/projectinfo/projectinfo?id=' + this.data.param_pid + '&project_name=' + this.data.param_pname });

      }
    }
  }
});
