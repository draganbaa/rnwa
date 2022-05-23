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
              <a href="./">STUDENTI</a>
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
              
              </div>
              <div>
                  
              </div>
            </div>
            <br />
            <div id="result">
            <table class="table">
                <tbody>
                <?php include 'read.php'; ?>
                </tbody>
            </table>
            <form class="form-inline m-2" action="create.php" method="POST">
                <label for="name">Name:</label>
                <input type="text" class="form-control m-2" id="name" name="name">
                <label for="score">Hod_id:</label>
                <input type="number" class="form-control m-2" id="hod_id" name="hod_id">
                <button type="submit" class="btn btn-primary">Add</button>
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
