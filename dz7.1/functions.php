<?php

function get_employees($id=0)
	{
	global $connection;
	$query="SELECT * FROM departments";
	if($id != 0)
	{
		$query.=" WHERE id=".$id." LIMIT 100";
	}
	$response=array();
	$result=mysqli_query($connection, $query);
	while($row=mysqli_fetch_array($result,MYSQLI_BOTH))
	{
		$response[]=$row;
	}
	header('Content-Type: application/json');
	echo json_encode($response);
	}

function insert_departments()
	{
		global $connection;

		$data = json_decode(file_get_contents('php://input'), true);
		$id		=$data["id"];
		$name			=$data["name"];
		$hod_id			=$data["hod_id"];

		
		echo $query="INSERT INTO departments VALUES (NULL, '".$id."','".$name."','".$hod_id."',NOW())";
		if(mysqli_query($connection, $query))
		{
			$broj_redaka = mysqli_affected_rows($connection);
			$response=array(
				'status' => 1,
				'query' => $query,
				'broj_redaka' => $broj_redaka,
				'status_message' =>'Department Added Successfully.'
			);
		}
		else
		{
			$broj_redaka = mysqli_affected_rows($connection);
			$response=array(
				'status' => 0,
				'query' => $query,
				'broj_redaka' => $broj_redaka,
				'status_message' =>'Department Addition Failed.'
			);
		}
		header('Content-Type: application/json');
		echo json_encode($response);
	}
function update_departments($id)
	{
		global $connection;
		$post_vars = json_decode(file_get_contents("php://input"),true);
		$name			=$data["name"];
		$hod_id			=$data["hod_id"];
		
		$query="UPDATE departments SET name='".$name."', hod_id='".$hod_id."' WHERE id=".$id;
		
		$result=mysqli_query($connection, $query);
		$broj_redaka = mysqli_affected_rows($connection);;
		
		if($result)
		{
			$response=array(
				'status' => 1,
				'query' => $query,
				'broj_redaka' => $broj_redaka,
				'status_message' =>'Department Updated Successfully.'
			);
		}
		else
		{
			$response=array(
				'status' => 0,
				'query' => $query,
				'broj_redaka' => $broj_redaka,
				'status_message' =>'Department Updation Failed.'
			);
		}
		header('Content-Type: application/json');
		echo json_encode($response);
	}

function delete_departments($id)
	{
	global $connection;
	$query="DELETE FROM departments WHERE id=".$id;
	if($result = mysqli_query($connection, $query))
	{
		$response=array(
			'status' => 1,
			'status_message' =>'Department Deleted Successfully.'
		);
	}
	else
	{
		$response=array(
			'status' => 0,
			'status_message' =>'Department Deletion Failed.'
		);
	}
	header('Content-Type: application/json');
	echo json_encode($response);
	}


?>
