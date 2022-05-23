<?php
  include './db.php';
  $id = $_POST['id'];
  $name = $_POST['name'];
  $hod_id = $_POST['hod_id'];
  $sql = "update departments set name='$name', hod_id='$hod_id' where id=$id";
  $result = $conn->query($sql);
  $conn->close();
  header("location: index.php");
?>