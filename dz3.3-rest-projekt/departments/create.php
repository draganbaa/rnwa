<?php
  include './db.php';
  $name = $_POST["name"];
  $hod_id = $_POST["hod_id"];
  $sql = "insert into departments (name, hod_id) values ('$name', '$hod_id')";
  $conn->query($sql);
  $conn->close();
  header("location: index.php");
?>