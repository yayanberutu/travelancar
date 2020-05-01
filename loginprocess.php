<?php
	include "connect.php";
	if (isset($_POST['submit'])){
			$username = $connectdb -> real_escape_string($_POST['username']);
		 	$password = $connectdb -> real_escape_string($_POST['password']);
			$query = $connectdb->query("SELECT * FROM user WHERE username='$username'and password='$password' ")or die(mySQli_error($connectdb));
			$row = $query->fetch_array();
		}

	if($row['username']==$username && $row['password']==$password){
		echo"<script> alert(\"Selamat datang di BankBung\");
		location.href=\"home.php\";</script>";
	}
	else{
		echo"<script>alert(\"username atau password anda salah\");
			location.href=\"login.php\";</script>";
	}
?>