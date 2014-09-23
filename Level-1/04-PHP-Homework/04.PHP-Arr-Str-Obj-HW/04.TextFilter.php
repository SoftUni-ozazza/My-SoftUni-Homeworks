<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <link href="Styles/styles.css" rel="stylesheet"/>
    <title>Text Filter</title>
</head>
<body>
<article>
    <form method="post">
        <textarea name="inputText"></textarea>
        <label>Banlist</label><input type="text" name="banlist" id="banlist"/>
        <input type="submit" name="submitButton" value="Filter"/>
    </form>
</article>
<?php function drawAsterixByStringLength($string)
{
    ?>
    <?php $result = ""; ?>
    <?php for ($k = 0; $k < strlen($string); $k++) : ?>
    <?php $result = $result . "*"; ?>
<?php endfor ?>
    <?php return $result; ?>
<?php } ?>

<?php if (isset($_POST['submitButton'])) : ?>
    <?php $text = $_POST['inputText']; ?>
    <?php $banlist = preg_split('/[,\s]+/', $_POST['banlist'], -1, PREG_SPLIT_NO_EMPTY); ?>
    <?php $newText = ""; ?>

    <?php foreach ($banlist as $banWord) : ?>

        <!-- ??? WHY ??? That function prints itself inside php? -->
        <?php $newWord = drawAsterixByStringLength($banWord); ?>
        <?= $text = str_replace($banWord, $newWord, $text); ?>

    <?php endforeach ?>
    <article>
        <p>HELLO for Check</p>
        <p><?php echo $text; ?></p>
    </article>
<?php endif ?>
</body>
</html>