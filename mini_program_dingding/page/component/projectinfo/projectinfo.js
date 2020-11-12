let app = getApp();
Page({
  data: {
    activeTab: 0,
    tabs: [
      { title: '项目详情' },
      { title: '当前进度' },
      { title: '操作' },
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
  }
});
