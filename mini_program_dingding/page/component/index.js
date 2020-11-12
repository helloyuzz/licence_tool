import lifecycle from '/util/lifecycle';
import animModal from '/util/items';

const lastComponents = [
  // {
  //   icon: '/image/canvas.png',
  //   title: '画布',
  //   entitle: 'Canvas',
  //   page: 'canvas',
  // },
];

Page({
  ...lifecycle,
  ...animModal.animOp,
  data: {
    ...animModal.data,
    pageName: 'component/index',
    pageInfo: {
      pageId: 0,
    },
    hidden: true,
    curIndex: 0,
    arr: {
      onItemTap: 'onGridItemTap',
      onChildItemTap: 'onChildItemTap',
      list: [
        {
          icon: '/image/view.png',
          title: '员工管理',
          entitle: 'Employee Management',
          subs: [
            {
              title: '员工列表',
              entitle: 'Change Employee role',
              page: 'aclist',
            },
            {
              title: '组织结构同步',
              entitle: 'Synchronization',
              page: 'rootsync',
            }
          ],
        }, {
          icon: '/image/form.png',
          title: '项目列表',
          entitle: 'Proejct List',
          subs: [
            {
              title: '所有项目',
              entitle: 'View Projects',
              page: 'projectlist',
            }, {
              title: '录入新项目',
              entitle: 'Create Project',
              page: 'newproject',
            }
          ],
        }, {
          icon: '/image/basic.png',
          title: '代理商管理',
          entitle: 'Agent Management',
          subs: [
            {
              title: '代理商列表',
              entitle: 'Change agent role',
              page: 'text',
            }
          ],
        }, {
          icon: '/image/api_scan.png',
          title: '申请授权码',
          entitle: '',
          page: 'scan',
        }, {
          icon: '/image/feedback.png',
          title: '系统日志',
          entitle: 'Feedback',
          subs: [
            {
              title: '登录日志',
              entitle: 'System login',
              page: 'login',
            }, {
              title: '授权日志',
              entitle: 'Authorization',
              page: 'auth',
            }
          ],
        }, {
          icon: '/image/biz_dropdown.png',
          title: '使用手册',
          entitle: 'Help',
          page: 'help',
        }, {
          icon: '/image/navigator.png',
          title: '关于',
          entitle: 'Media', page: 'about',
        },
        ...lastComponents,
      ],
    },
  },
  onGridItemTap(e) {
    const curIndex = e.currentTarget.dataset.index;
    const childList = this.data.arr.list[curIndex];
    if (childList.subs) {
      this.setData({
        hidden: !this.data.hidden,
        curIndex,
      });
      this.createMaskShowAnim();
      this.createContentShowAnim();
    } else {
      this.onChildItemTap({
        currentTarget: {
          dataset: { page: childList.page },
        },
      });
    }
  },
  onChildItemTap(e) {
    const { page } = e.currentTarget.dataset;
    // my.alert({
    //   content: page
    // });
    if (page == "scan") {
      my.scan({
        scanType: ['qrCode', 'barCode'],
        success: (res) => {
          my.alert({ title: res.code });
        },
      });
    } else {
      dd.navigateTo({
        url: `${page}/${page}`,
      });
    }
  },
  onModalCloseTap() {
    this.createMaskHideAnim();
    this.createContentHideAnim();
    setTimeout(() => {
      this.setData({
        hidden: true,
      });
    }, 210);
  },
});
