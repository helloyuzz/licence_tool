let app = getApp();
Page({
  data: {
    stepArray: [{ step_index: -1, step_content: '请选择' }],
    stepIndex: 0,
    project_name: '',
    sign_date: '',
    finish_date: '',
    emplyee_id: '',
    employee_name: '',
    step_Array_Content: '请选择',
    step_Array_Id: '',
    unique_code: '',
    project_desc: '',
    employee_Array: [{ id: -1, name: '请选择', }],
    employee_Index: 0
  },
  async onLoad() {
    my.showLoading({ content: "正在加载..." });

    var dt = Date();
    this.setData({ sign_date: dt.toString()}); 

    // Load ProjectStep
    this.setData({ stepArray: [] });
    var tempStepArray = [];
    var tempStepIndex = -1;
    var stepArray = await app.loadStepArray();
    if (stepArray != null) {
      stepArray.original_array.forEach(item => {
        if (item.step_index >= 0) {
          tempStepArray.push({ 'step_index': item.step_index, 'step_content': item.step_content });
        }
      });
      this.setData({ stepArray: tempStepArray });
    }
 
    // Load All Employee
    this.setData({ employee_Array: [] });
    var getEmployees = await app.getAllEmployee();
    var tempEmployees = [];

    if (getEmployees != null) {
      getEmployees.forEach(item => {
        tempEmployees.push({ 'id': item.id, 'name': item.name });
      });
      this.setData({ employee_Array: tempEmployees });
    }
  },
  stepIndexPickerChange(e) {
    this.setData({
      stepIndex: e.detail.value, step_Array_Id: this.data.stepArray[e.detail.value].step_index, step_Array_Content: this.data.stepArray[e.detail.value].step_content,
    });
  },
  employeePickerChange(e) {
    this.setData({
      employee_Index: e.detail.value, emplyee_id: this.data.employee_Array[e.detail.value].id, employee_name: this.data.employee_Array[e.detail.value].name,
    });
  },
  onItemInput(e) {
    this.setData({
      [e.target.dataset.field]: e.detail.value,
    });
  },
  onItemClear(e) {
    this.setData({
      [e.target.dataset.field]: '',
    });
  },
  onDescInput(e) {
    this.setData({
      desc: e.detail.value,
    });
  },
  async onSaveProjectTap() {
    var showContent = "";
    if (this.data.project_name == "") {
      showContent = "项目名称不能为空";
    } else if (this.data.sign_date == "") {
      showContent = "合同日期不能为空";
    } else if (this.data.finish_date == "") {
      showContent = "预计完工日期不能为空";
    } else if (this.data.emplyee_id == "") {
      showContent = "请选择实施员工";
    } else if (this.data.current_progress == "请选择") {
      showContent = "请选择当前进度";
    }
    if (showContent == "") {
      my.showLoading({
        content: '正在保存...'
      });

      var project = {};
      project.project_name = this.data.project_name;
      project.fk_employee_id = this.data.emplyee_id;
      project.sign_date = this.data.sign_date;
      project.finish_date = this.data.finish_date;
      project.current_progress = this.data.current_progress;
      project.unique_code = '';
      project.project_desc = this.data.project_desc;

      await my.httpRequest({
        url: 'http://ajcc.vaiwan.com/project/saveProject',
        method: 'POST',
        data: JSON.stringify(project),
        headers: {
          'content-type': 'application/json'  //默认值
        },
        dataType: 'json',
        success: function (res) {
          showContent = "保存成功";
        },
        fail: function (res) {

        },
        complete: function (res) {
          my.hideLoading();
        }
      });
    }
    if (showContent == "保存成功") {
      await my.alert({ content: showContent });
      my.navigateTo({ url: '../projectlist/projectlist' });
    } else {
      my.showToast({
        type: 'none',
        content: showContent,
        duration: 2000,
      });
    }
  },
  on_datePicker(evt) {
    var argu = evt.target.dataset.attr;
    my.datePicker({
      currentDate: '{{sign_date}}',
      startDate: '2019-10-18',
      endDate: '2021-10-18',
      success: (res) => {
        if (argu == 'a') {
          this.setData({ sign_date: res.date });
        } else {
          this.setData({ finish_date: res.date });
        }
      },
    });
  },
  onActionSheetPickerTap(evt) {
    var argu = evt.target.dataset.attr;
    var title = "选择实施员工";
    var items = [];
    if (argu == "Employee") {
      items = this.data.employees;
    } else {
      items = this.data.progress;
      title = "选择项目进度";
    }
    my.showActionSheet({
      title: title,
      items: items,
      success: (res) => {
        if (argu == "Employee") {
          this.setData({
            employee_name: this.data.employees[res.index],
          });
        } else {
          this.setData({
            current_progress: this.data.progress[res.index],
          });
        }
      },
    });
  },
});
