<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/01.rootSum.css" rel="stylesheet"/>
    <title>Randomizer</title>
</head>
<body>
<article>
    <form method="post">
        <p>Enter cars and split them by comma:</p>
        <input type="text" name="cars"/><br>
        <input type="submit" value="Send" name="Send"/><br>
    </form>
</article>
<?php
if ((isset($_POST['cars'])) && (!empty($_POST['cars']))) {
    $carsList = htmlentities($_POST['cars']);
    $cars = preg_split('/[ , ]+/', $carsList);
    ?>
    <table>
        <tr>
            <th>Cars</th>
            <th>Color</th>
            <th>Count</th>
        </tr>
        <?php
        $carColors = ['red', 'blue', 'yellow', 'white', 'black',];
        foreach ($cars as $carName) {
            $count = rand(1, 5);
            $randColors = array_rand($carColors);
            ?>
            <tr>
                <td><?= $carName ?></td>
                <td><?= $carColors[$randColors] ?></td>
                <td><?= $count ?></td>
            </tr>
        <?php
        }
        ?>
    </table>
<?php
}elseif((isset($_POST['cars'])) && (empty($_POST['cars']))){
    echo('Fill the form!');
}
?>

</body>
</html>