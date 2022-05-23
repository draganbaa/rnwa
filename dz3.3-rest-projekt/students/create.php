<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <link rel="stylesheet" href="../../dz1/style.css" />
    <title>Students Database</title>
  </head>
  <body>
    <div class="container">
      <header>
        <a href="../../dz1/index.html">
          <div class="logo">
            <img src="../../dz1/logo.jpeg" alt="College Logo" />
          </div>
        </a>
        <nav>
          <ul>
            <li>
              <a href="index.php" class="active">STUDENTI</a>
            </li>
            <li>
              <a href="../../dz1/fakulteti.html">FAKULTETI</a>
            </li>
            <li>
              <a href="../../dz1/admin.html">ADMINISTRATOR</a>
            </li>
          </ul>
        </nav>
      </header>
      <main>
        <article>
          <div class="card">
            <div class="item">
              <h3>STUDENTI</h3>
            </div>
            <div class="form-group">
              <div class="input-group">
                <!-- <span class="input-group-addon">Search</span>
                <input
                  type="text"
                  name="search_text"
                  id="search_text"
                  placeholder="Pretaži studente"
                  class="form-control"
                /> -->
                <!-- <button>
                    <a href="create.php">Dodaj Studenta</a>
                  </button> -->
              </div>
              <div>
                  
              </div>
            </div>
            <br />
            <div id="result">
                    <form action="create.php" method="POST">
                    <div class="form-group">
                            <label>roll_num</label>
                            <input id="roll_num" name="roll_num" type="text">
                        </div>
                        <div class="form-group">
                            <label>First_Name</label>
                            <input id="first_name" name="first_name" type="text">
                        </div>
                        <div class="form-group">
                            <label>Last_Name</label>
                            <input id="last_name" name="last_name" type="text">
                        </div>
                        <div class="form-group">
                            <label>department_id</label>
                            <input id="department_id" name="department_id" type="text">
                        </div>
                        <div class="form-group">
                            <label>phone</label>
                            <input id="phone" name="phone" type="text">
                        </div>
                        <div class="form-group">
                            <label>admission_date</label>
                            <input id="admission_date" name="admission_date" type="text">
                        </div>
                        <div class="form-group">
                            <label>cet_marks</label>
                            <input id="cet_marks" name="cet_marks" type="text">
                        </div>
                        <input type="submit" class="btn btn-primary" value="Submit">
                        <a href="index.php" class="btn btn-secondary ml-2">Cancel</a>
                    </form>
                    </div>
          </div>
        </article>
      </main>

      <footer>
        <p>FSRE 2022. &copy; Andro Raspudić Dragan Drljepan</p>
      </footer>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>

    <script src="../dz3/script.js"></script>
  </body>
</html>

<?php
// Include config file
include './config.php';
  $roll_num = $_POST["roll_num"];
  $first_name = $_POST["first_name"];
  $last_name = $_POST["last_name"];
  $department_id = $_POST["department_id"];
  $phone = $_POST["phone"];
  $admission_date = $_POST["admission_date"];
  $cet_marks = $_POST["cet_marks"];
  $sql = "insert into students (roll_num, first_name, last_name, department_id, phone, admission_date, cet_marks) values ('$roll_num', '$first_name', '$last_name', '$department_id', '$phone', '$admission_date', '$cet_marks')";
  $link->query($sql);
  $link->close();
  header("location: index.php");

?>