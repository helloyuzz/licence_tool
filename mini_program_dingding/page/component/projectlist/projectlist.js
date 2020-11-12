let app = getApp();

Page(
  {
    data: {
      stepArray: [],
      stepIndex: 0,
      cacheStep: {},
      swipeIndex: null,
      list: [
        // { right: [{ type: 'other', text: '审批通过' }, { type: 'delete', text: '审批拒绝' }], upperSubtitle: '实施人员：陈坤', licenceTo: '授权日期：yyyy-MM-dd', content: '四川省中医' },
      ],
      btn_Text: '正在加载...',
    },
    async loadProjectWithStep(step_index) {
      // Load Projects，加载项目列表
      // 可以根据不同项目加载
      // 默认加载所有项目，考虑到实际项目数量，暂不分页
      this.setData({ list: [] });      

      var projectList = await app.loadProjectWithStep(step_index,'all');

      this.setData({ list: projectList, btn_Text: '所有项目(' + projectList.length + ')' });
    },
    async loadProjectStep() {  // Load StepArray，加载项目列表阶段过滤条件            
      var stepArray = await app.loadStepArray();

      this.setData({ stepArray: stepArray.content_array });
      this.setData({ cacheStep: stepArray.original_array });
    },
    async onLoad(param) {
      console.log(param.argu);
      my.showLoading({ content: "加载中..." });

      await this.loadProjectStep();
      await this.loadProjectWithStep(-1);

      my.hideLoading();
      // dd.setNavigationBar(
      //   { title: '项目列表(' + this.data.list.length + ')' }
      // );
      // if (my.canIUse('hideBackHome')) {
      //   my.hideBackHome();
      // }
    }, stepIndexPickerChange(e) {
      //console.log('picker发送选择改变，携带值为', e.detail.value);
      this.setData({
        stepIndex: e.detail.value,
      });
    },
    onRightItemClick(e) {
      const { type } = e.detail;
      var showContent = '';
      if (type == 'other') {
        // showContent = "确定" + this.data.swipeIndex;
        my.confirm({
          title: '温馨提示',
          content: '是否通过该申请？',
          confirmButtonText: '确定',
          cancelButtonText: '取消',
          success: (result) => {
            my.alert({
              title: `${result.confirm}`,
            });
          },
        });
      } else if (type == 'delete') {
        my.confirm({
          title: '温馨提示',
          content: '是否拒绝该申请？',
          confirmButtonText: '确定',
          cancelButtonText: '取消',
          success: (result) => {
            my.alert({
              title: `${result.confirm}`,
            });
          },
        });
      }
    },
    onItemClick(e) {
      var id = this.data.list[e.index].id;
      var project_name = this.data.list[e.index].content;

      dd.navigateTo({
        url: '/page/component/projectinfo/projectinfo?id=' + id + '&project_name=' + project_name,
      });
    },
    onSwipeStart(e) {
      this.setData({
        swipeIndex: e.index,
      });
    }, async onSwitchProject() {
      var selectIndex = -1;
      await dd.showActionSheet({
        title: '',
        items: this.data.stepArray,
        cancelButtonText: '取消',
        success: (res) => {
          selectIndex = res.index;
        },
      });
      if (selectIndex >= 0) {
        var btnText = this.data.stepArray[selectIndex];
        var tempText = btnText;
        if (btnText.indexOf('(') > 0) {
          tempText = btnText.substring(0, btnText.indexOf('('));
        }
        var cache_step_index = -1;
        var cache_step_count = 0;
        console.log(this.data.cacheStep.length);

        this.data.cacheStep.forEach(item => {
          console.log(item.step_content + ":" + item.project_count);
          if (item.step_content == tempText) {
            cache_step_index = item.step_index;
            if (item.project_count != null) {
              cache_step_count = item.project_count;
            }
          }
        });
        await this.loadProjectWithStep(cache_step_index);
        this.setData({
          btn_Text: tempText + '(' + cache_step_count + ')',
        });
      }
    },
  });