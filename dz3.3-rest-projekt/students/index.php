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
              <a href="./" class="active">STUDENTI</a>
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
                <span class="input-group-addon">Search</span>
                <input
                  type="text"
                  name="search_text"
                  id="search_text"
                  placeholder="Pretaži studente"
                  class="form-control"
                />
                <button>
                    <a href="create.php">Dodaj Studenta</a>
                  </button>
              </div>
              <div>
                  
              </div>
            </div>
            <br />
            <div id="result">
            <?php
                    // Include config file
                    require_once "config.php";
                    
                    // Attempt select query execution
                    $sql = "SELECT * FROM students";
                    if($result = mysqli_query($link, $sql)){
                        if(mysqli_num_rows($result) > 0){
                            echo '<table class="table table-bordered table-striped">';
                                echo "<thead>";
                                    echo "<tr>";
                                        echo "<th>#</th>";
                                        echo "<th>First_Name</th>";
                                        echo "<th>last_name</th>";
                                        echo "<th>department_id</th>";
                                        echo "<th>phone</th>";
                                        echo "<th>admission_date</th>";
                                        echo "<th>cet_marks</th>";
                                        echo "<th>Action</th>";
                                    echo "</tr>";
                                echo "</thead>";
                                echo "<tbody>";
                                while($row = mysqli_fetch_array($result)){
                                    echo "<tr>";
                                        echo "<td>" . $row['roll_num'] . "</td>";
                                        echo "<td>" . $row['first_name'] . "</td>";
                                        echo "<td>" . $row['last_name'] . "</td>";
                                        echo "<td>" . $row['department_id'] . "</td>";
                                        echo "<td>" . $row['phone'] . "</td>";
                                        echo "<td>" . $row['admission_date'] . "</td>";
                                        echo "<td>" . $row['cet_marks'] . "</td>";
                                        echo "<td>";
                                            echo '<button><a href="update.php?id='. $row['roll_num'] .'">Edit</a></button>';
                                            echo '<button><a href="delete.php?id='. $row['roll_num'] .'">Delete</a></button>';
                                        echo "</td>";
                                    echo "</tr>";
                                }
                                echo "</tbody>";                            
                            echo "</table>";
                            // Free result set
                            mysqli_free_result($result);
                        } else{
                            echo '<div class="alert alert-danger"><em>No records were found.</em></div>';
                        }
                    } else{
                        echo "Oops! Something went wrong. Please try again later.";
                    }
 
                    // Close connection
                    mysqli_close($link);
                    ?>
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
