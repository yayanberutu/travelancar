<!DOCTYPE html>
<html>
<head>
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="css/lgn.css">
	<link href="https://fonts.googleapis.com/css?family=Pacifico&display=swap" rel="stylesheet">
</head>
<body background="image/bgs.jpg">
	<div class="container">
		<div class="header">
			<h2 style="font-family: 'Pacifico' , cursive; font-size: 50px;">Bank Bung</h2>
		</div>
		<div class="content">
			<div class="awl">
				<img src="image/icon.jpg"  id= "lgn"></a>
			</div>
			<div class="mdl">
				<form action="loginprocess.php" method="POST">
					<fieldset>
						<legend>Form Login</legend>
						<br>
							<table>
								<tr>
									<td>
										<label>Username</label>
									</td>
									<td>:</td>
									<td>
										<input type="text" name="username" class="ktk_lgn">
									</td>
								</tr>
								<tr>
									<td>
										<label>Password</label>
									</td>
									<td>
										:
									</td>
									<td>
										<input type="password" name="password" class="ktk_lgn">
									</td>
								</tr>
							</table>
							<br>
							<br>
							<button type="submit" name="submit" class="btm">Login</button>
					</fieldset>
				</form>
			</div>
		</div>
	</div>	
</body>
</html>