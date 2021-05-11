<?php
  include ('header.php');
?>

<html>
<head>
    <title>Profile - Page</title>
    <link  rel="stylesheet"
      href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="../css/styles.css">
</head>


<body class="profile-page">
    <div class="container">
        <main>
            <div class="card-container">
            
                <div class="upper-container">
                    <div class="image-container">
                        <img src="../images/profile-page.jpeg">
                    </div>
                </div>
                <div class="lower-container">
                    <form action="../includes/change-password-inc.php" method="post">
                        <div>
                            <br>
                            <h3>New Password:</h3>
                            <br>
                            <input type="password" name="newPassword">
                            <br><br>
                            <h3>Repeat Password:</h3>
                            <br>
                            <input type="password" name="repeatNewPassword">
                            <br><br>
                            <input type="submit" name="submit" value="Change Password" class="btn"></a>
                        </div>
                    </form>
                </div>
            </div>
        </main>

        <?php
            include ('sidebar.php');
        ?>

    </div>
</body>
</html>