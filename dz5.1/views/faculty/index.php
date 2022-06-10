<p>faculty:</p>

<?php foreach($faculty as $facult) { ?>
  <p>
    <?php echo $facult->first_name ." ".$facult->last_name ." ".$facult->department_id ." ".$facult->phone  ?>
    <a href='?controller=faculty&action=show&id=<?php echo $facult->id; ?>'>Vidi detalje</a>
  </p>
<?php } ?>