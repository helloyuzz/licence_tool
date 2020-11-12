Page({
  data: {
    systemInfo: {}
  },
  getSystemInfo() {

  },
  getSystemInfoSync() {
    this.setData({
      systemInfo: my.getSystemInfoSync(),
    });
  },
  onShow() {
    getSystemInfo();
  },
  onLoad() {
        // my.showToast({
        //   type: 'success',
        //   content: '操作成功',
        //   duration: 3000,
        //   success: () => {
        //     my.alert({
        //       title: 'toast 消失了',
        //     });
        //   },
        // });
    my.getSystemInfo({
      success: (res) => {

        this.setData({
          systemInfo: res
        })
      }
    })
  }
}
)
