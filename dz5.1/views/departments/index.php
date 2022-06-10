<p>departments:</p>

<?php foreach($departments as $department) { ?>
  <p>
    <?php echo $department->name ." ".$department->hod_id  ?>
    <a href='?controller=departments&action=show&id=<?php echo $department->ID; ?>'>Vidi detalje</a>
  </p>
<?php } ?>