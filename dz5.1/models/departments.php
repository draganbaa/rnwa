<?php
  class Departments {
    // we define 3 attributes
    // they are public so that we can access them using $post->author directly
    public $ID;
    public $name;
    public $hod_id;

    public function __construct($ID, $name, $hod_id) {
      $this->ID      = $ID;
      $this->name  = $name;
      $this->hod_id = $hod_id;
    }

    public static function all() {
      $list = [];
      $db = Db::getInstance();
      $req = $db->query('SELECT * FROM departments');


      // we create a list of Post objects from the database results
      foreach($req->fetchAll() as $post) {
        $list[] = new Departments($post['ID'], $post['name'], $post['hod_id']);
      }

      return $list;
    }

    public static function find($id) {
      $db = Db::getInstance();
      // we make sure $id is an integer
      $id = intval($id);
      $req = $db->prepare('SELECT * FROM departments WHERE ID = :id');
      // the query was prepared, now we replace :id with our actual $id value
      $req->execute(array('id' => $id));
      $post = $req->fetch();

      return new Departments($post['ID'], $post['name'], $post['hod_id']);
    }
  }
?>