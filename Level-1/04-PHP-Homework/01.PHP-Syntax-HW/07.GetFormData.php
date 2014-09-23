<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Set Data</title>
    <style>
        body{
            margin: 0;
            padding: 0;
        }
        article{
            display: inline-block;
            margin: 1rem;
            padding: 0.5rem;
            border: 1px solid darkblue;
        }
        input {
            display: block;
            margin: 0.5rem;
            padding: 0.3rem;
        }
        input[type='radio']{
            display: inline;
        }
    </style>
</head>
    <body>
        <section>
            <article>
                <!-- Add HTML Form -->
                <?php echo "<form method='post'>\n" ?>
                    <?php echo "<input type='text' name='name' placeholder='Name' >\n" ?>
                    <?php echo "<input type='text' name='age' placeholder='Age' >\n" ?>
                    <?php echo "<label for='female'><input type='radio' id='sex_female' name='sex' value='female' >Female</label><br>" ?>
                    <?php echo "<label for='male'><input type='radio' id='sex_male' name='sex' value='male'>Male</label><br>" ?>
                    <?php echo "<input type='submit' name='submit' value='Submit'>\n" ?>
                <?php echo "</form>\n" ?>

                <?php
                if(isset($_POST['submit']) &&
                    ($_POST['submit'] == 'Submit') &&
                    (count($_POST) == 4)){

                    $name = htmlentities($_POST['name']);
                    $age = htmlentities($_POST['age']);
                    $sex = htmlentities($_POST['sex']);

                    echo "<p>My name is $name. I'm $age years old. I'm $sex.</p>";

                }else{

                    echo "<p>Please, check all fields!</p>";

                }
                ?>
            </article>
        </section>
    </body>
</html>

