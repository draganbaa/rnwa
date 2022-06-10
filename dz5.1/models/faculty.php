<?php
  class Faculty {
    // we define 3 attributes
    // they are public so that we can access them using $post->author directly
    public $id;
    public $first_name;
    public $last_name;
    public $department_id;
    public $phone;

    public function __construct($id, $first_name, $last_name, $department_id, $phone) {
      $this->id      = $id;
      $this->first_name  = $first_name;
      $this->last_name = $last_name;
      $this->department_id  = $department_id;
      $this->phone = $phone;
    }

    public static function all() {
      $list = [];
      $db = Db::getInstance();
      $req = $db->query('SELECT * FROM faculty');

      // we create a list of Post objects from the database results
      foreach($req->fetchAll() as $post) {
        $list[] = new Faculty($post['id'], $post['first_name'], $post['last_name'], $post['department_id'], $post['phone']);
      }

      return $list;
    }

    public static function find($id) {
      $db = Db::getInstance();
      // we make sure $id is an integer
      $id = intval($id);
      $req = $db->prepare('SELECT * FROM pofacultysts WHERE id = :id');
      // the query was prepared, now we replace :id with our actual $id value
      $req->execute(array('id' => $id));
      $post = $req->fetch();

      return new Faculty($post['id'], $post['first_name'], $post['last_name'], $post['department_id'], $post['phone']);
    }
  }
?>