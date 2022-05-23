<?php
  include './config.php';
  $id = $_GET['id'];
  $sql = "delete from students where roll_num=$id";
  $link->query($sql);
  $link->close();
  header("location: index.php");
?>