<?php
  function call($controller, $action) {
    require_once('controllers/' . $controller . '_controller.php');

    switch($controller) {
      case 'pages':
        $controller = new PagesController();
      break;
	  case 'departments':
        require_once('models/departments.php');
		$controller = new DepartmentsController();
      break;
	   case 'students':
        require_once('models/students.php');
		$controller = new StudentsController();
      break;
      case 'faculty':
        // we need the model to query the database later in the controller
        require_once('models/faculty.php');
        $controller = new FacultyController();
      break;
    }

    $controller->{ $action }();
  }

  // we're adding an entry for the new controller and its actions
  $controllers = array('pages' 		=> ['home', 'error'],
                       'faculty' 		=> ['index', 'show'],
					   'departments' => ['index', 'show'],
					   'students' 	=> ['index', 'show','deletestudents']);

  if (array_key_exists($controller, $controllers)) {
    if (in_array($action, $controllers[$controller])) {
      call($controller, $action);
    } else {
      call('pages', 'error');
    }
  } else {
    call('pages', 'error');
  }
?>