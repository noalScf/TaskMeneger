var apiURL = 'http://localhost:8985/TaskService.svc/'

var vmTask = new Vue({

  el: '#tasks',

  data: {
    currentBranch: 'Tasks',
    task: null,
	hide: true,
	taskHeader:'',
	taskText:''
  },

  created: function () {
    this.getTask();
  },
  
  methods: {
    getTask: function () {
      var xhr = new XMLHttpRequest();
      var self = this;
      xhr.open('GET', apiURL + self.currentBranch);
      xhr.onload = function () {
        self.task = JSON.parse(xhr.responseText);
        console.log(self.task[0]);
      }
      xhr.send();
    },
	
	add: function () {
var Json = {
  "textHeader":this.taskHeader,   
  "text":this.taskText
};
console.log(Json);
        $.ajax({
            url: "http://localhost:8985/TaskService.svc/AddTask",
            data: JSON.stringify(Json),
            type: "POST",
            processData: false,
            async: false,
            contentType: "application/json",
            dataType: "json",
            success:
                    function (response) {
						vmTask.task.push(response);
                    },
            error: function (er) {
				console.log(er)
            }
        });
    }
	
  }
})


