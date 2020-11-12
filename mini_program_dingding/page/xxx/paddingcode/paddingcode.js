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
      //console.log(param.aa);
      // console.log(this.name);

      var tempList = await app.loadProjectWithStep(1, 'paddingcode');
      this.setData({ projectList: tempList });
      // my.setTabBarBadge({
      //   index: 0,
      //   text: getProjects.length
      // });
    },
    onRightItemClick(e) {
      const { type } = e.detail;
      var showContent = '';
      if (type == 'other') {
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
      this.setData({ swipeIndex: -1 });
    },
    onItemClick(e) {
      var projectId = this.data.projectList[e.index].id;
      var projectName = this.data.projectList[e.index].content;
      dd.navigateTo({
        url: `/page/component/projectinfo/projectinfo?id=` + projectId + '&project_name=' + projectName,
      });
    },
    onSwipeStart(e) {
      this.setData({
        swipeIndex: e.index,
      });
    },
  });