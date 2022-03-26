<?php
$connect = mysqli_connect("localhost", "root", "", "collegeDB");
$output = '';
if(isset($_POST["query"]))
{
	$search = mysqli_real_escape_string($connect, $_POST["query"]);
	$query = "
	SELECT * FROM students 
	WHERE first_name LIKE '%".$search."%'
	OR last_name LIKE '%".$search."%' 
	";
}
else
{
	$query = "
	SELECT * FROM students ORDER BY first_name";
}
$result = mysqli_query($connect, $query);
if(mysqli_num_rows($result) > 0)
{
	$output .= '<div class="table">
					<table class="table">
						<tr>
							<th>Roll No.</th>
							<th>Ime</th>
							<th>Prezime</th>
							<th>Odjel</th>
							<th>Broj</th>
                            <th>Datum prijave</th>
                            <th>CeT Ocjena</th>
                            <th>*</th>
						</tr>';
	while($row = mysqli_fetch_array($result))
	{
		$output .= '
			<tr>
				<td>'.$row["roll_num"].'</td>
				<td>'.$row["first_name"].'</td>
				<td>'.$row["last_name"].'</td>
				<td>'.$row["department_id"].'</td>
				<td>'.$row["phone"].'</td>
                <td>'.$row["admission_date"].'</td>
				<td>'.$row["cet_marks"].'</td>
				<td><button>Detalji</button>
                <button>Uredi</button>
                <button>Obriši</button>
                </td>
			</tr>
		';
	}
	echo $output;
}
else
{
	echo 'Student nije u bazi';
}
?>