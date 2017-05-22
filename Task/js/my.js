var apiURL = 'http://localhost:8985/TaskService.svc/'

var vmTask = new Vue({
	
	el: '#tasks',
	
	data: {
		currentBranch: 'Tasks',
		task: null,
		hide: true,
		NewTaskHeader:'',
		NewTaskText:''
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
			}
			xhr.send();
		},
		
		add: function () {
			var Json = {
				"TextHeader":this.NewTaskHeader,   
				"Text":this.NewTaskText,
				"idStatus":2,
				"Komentarii" :"комент 1"
				
			};
			$.ajax({
				url: "http://localhost:8985/TaskService.svc/AddTask",
				data: JSON.stringify(Json),
				type: "POST",
				processData: false,
				async: false,
				contentType: "application/json; charset=utf-8",
				dataType: "json",
				success:
				function (response) {
					vmTask.task.push(response);
					$('#addTaskModal').modal('hide')
				},
				error: function (er) {
					console.log(er);	
				}
			});
		}
		
	}
})



$(document).ready(function() {

	$('tr').each(function() {
		$( this ).find('#article').readmore({
			maxHeight: 40,
			moreLink: '<a href="#">Подробнее</a>',
			lessLink: '<a href="#">Скрыть</a>'
		});
		
		
	});
});


