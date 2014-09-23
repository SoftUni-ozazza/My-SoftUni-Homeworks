<?php
header("Content-Type: text/html; charset=UTF-8");
mb_internal_encoding("UTF-8");
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/styles.css" rel="stylesheet"/>
    <title>Text Colorer</title>
</head>
<body>
<article>
    <form method="post">
        <textarea name="textInput"></textarea>
        <input type="submit" name="submitInput" value="Count Words"/>
    </form>
</article>
<?php
if (isset($_POST['submitInput'])) {
if (!empty($_POST['textInput'])) {
?>
<article>

    <?php
    $textarea = htmlentities($_POST['textInput']);
    $textToWords = preg_split($textToWords, 0, PREG_SPLIT_NO_EMPTY);

    foreach ($textToWords as $word) {

        // gets ASCII number of the char and checks if even or odd
        if (ord($word) % 2 == 0) {
            echo "<span class=\"color-red\">{$word}</span>";
        } else {
            echo "<span class=\"color-blue\">{$word}</span>";
        }
    }
    }
    }
    ?>
</article>

</body>
</html>