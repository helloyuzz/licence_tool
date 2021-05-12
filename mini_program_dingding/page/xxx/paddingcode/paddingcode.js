let app = getApp();
Page(
  {
    data: {
      swipeIndex: null,
      projectList: [
        // { right: [{ type: 'other', text: '审批通过' }, { type: 'delete', text: '审批拒绝' }], upperSubtitle: '实施人员：陈坤', licenceTo: '授权日期：yyyy-MM-dd', content: '四川省中医' },
      ],
      index: null,
    },
    async onLoad(param) {
      var tempList = await app.loadProjectWithStep(app.ProjectStep.step_waitting_licence, app.FromPage.paddingcode);
      this.setData({ projectList: tempList });
    },
    async onRightItemClick(e) {
      const { type } = e.detail;

      if (type == 'other') {
        
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
      this.setData({ swipeIndex: -1 });
    },
    onItemClick(e) {
      var projectId = this.data.projectList[e.index].id;
      var projectName = this.data.projectList[e.index].content;
      dd.navigateTo({
        url: `/page/component/projectinfo/projectinfo?id=` + projectId + '&project_name=' + projectName + '&is_Padding=true',
      });
    },
    onSwipeStart(e) {
      this.setData({
        swipeIndex: e.index,
      });
    },
  });