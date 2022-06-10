<p>All Students:</p>

<?php foreach($students as $student) { ?>
  <p>
    <?php echo $student->first_name ." ".$student->last_name ." ".$student->department_id ." ".$student->phone ." ".$student->admission_date ." ".$student->cet_marks  ?>
    <a href='?controller=students&action=deletestudents&id=<?php echo $student->roll_num; ?>'>Delete Student</a>
  </p>
<?php } ?>
