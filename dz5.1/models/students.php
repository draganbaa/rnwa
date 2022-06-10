<?php
  class Students  {
    // we define 3 attributes
    // they are public so that we can access them using $post->author directly
    public $roll_num;
    public $first_name;
    public $last_name;
    public $department_id;
    public $phone;
    public $admission_date;
    public $cet_marks;


    public function __construct($roll_num, $first_name, $last_name, $department_id, $phone, $admission_date, $cet_marks) {
      $this->roll_num      = $roll_num;
      $this->first_name  = $first_name;
      $this->last_name  = $last_name;
      $this->department_id  = $department_id;
      $this->phone  = $phone;
      $this->admission_date  = $admission_date;
      $this->cet_marks  = $cet_marks;

    }

    public static function all() {
      $list = [];
      $db = Db::getInstance();
      $req = $db->query('SELECT * FROM students');


      // we create a list of Post objects from the database results
      foreach($req->fetchAll() as $students) {
        $list[] = new Students($students['roll_num'], $students['first_name'], $students['last_name'], $students['department_id'], $students['phone'], $students['admission_date'], $students['cet_marks']);
      }

      return $list;
    }

    public static function find($id) {
      $db = Db::getInstance();
      // we make sure $id is an integer
      $id = intval($id);
      $req = $db->prepare('SELECT * FROM students WHERE roll_num = :id');
      // the query was prepared, now we replace :id with our actual $id value
      $req->execute(array('id' => $id));
      $students = $req->fetch();

      return new Students($students['roll_num'], $students['first_name'], $students['last_name'], $students['department_id'], $students['phone'], $students['admission_date'], $students['cet_marks']);
    }
	
	public static function deletestudents($id) {
      $db = Db::getInstance();
      // we make sure $id is an integer
      //$id = intval($id);
	  $sql="DELETE FROM students WHERE roll_num ='$id'";
	  //echo $sql;
	  
      //$req = $db->prepare($sql);
      // the query was prepared, now we replace :id with our actual $id value
      //if ($req->execute(array('id' => $id))){
		  //$req=$r->execute($sql);
	if ($db->query($sql) == TRUE){
	//if (1==2){
		  $rez="USPJESNO brisanje";
	  }
		  else {
			 $rez="NESPJESNO brisanje";;
		  }
		  return $rez;
	  
}
  }
?>