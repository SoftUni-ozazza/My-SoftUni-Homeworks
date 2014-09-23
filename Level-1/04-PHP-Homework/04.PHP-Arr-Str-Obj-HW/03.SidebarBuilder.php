<?php
header("Content-Type: text/html; charset=UTF-8");
mb_internal_encoding("UTF-8");
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="Styles/styles.css"/>
    <title>Sidebar Builder</title>
</head>
<body>
<article>
    <form method="post">
        <label for="categories">Categories</label><input type="text" name="categories" id="categories"/><br>
        <label for="tags">Tags</label><input type="text" name="tags" id="tags"/><br>
        <label for="months">Months</label><input type="text" name="months" id="months"/><br>
        <input type="submit" name="submitSidebar" value="Generate"/>
    </form>
</article>

<?php if (isset($_POST['submitSidebar'])) : ?>
    <aside>
    <?php if (isset($_POST['categories'])) : ?>
        <?php $categories = $_POST['categories']; ?>
        <h3>Categories</h3>
        <hr/>
        <ul>
            <?php $categories = preg_split('/[","]+/', $categories, -1, PREG_SPLIT_NO_EMPTY); ?>
            <?php foreach ($categories as $category) : ?>
                <?php $category = ucfirst($category); ?>
                <li><a href="#"><?= $category ?></a></li>
            <?php endforeach ?>
        </ul>
        </aside>
    <?php endif ?>
    <?php if (isset($_POST['tags'])) : ?>
        <aside>
        <?php $tags = $_POST['tags']; ?>
        <h3>Tags</h3>
        <hr/>
        <ul>
            <?php $tags = preg_split('/[","]+/', $tags, -1, PREG_SPLIT_NO_EMPTY); ?>
            <?php foreach ($tags as $tag) : ?>
                <?php $tag = strtolower($tag); ?>
                <li><a href="#"><?= $tag ?></a></li>
            <?php endforeach ?>
        </ul>
    <?php endif ?>
    </aside>
    <?php if (isset($_POST['months'])) : ?>
        <aside>
        <?php $months = $_POST['months']; ?>
        <h3>Months</h3>
        <hr/>
        <ul>
            <?php $months = preg_split('/[, ]+/', $months, -1, PREG_SPLIT_NO_EMPTY); ?>
            <?php foreach ($months as $month) : ?>
                <?php $month = ucfirst($month); ?>
                <li><a href="#"><?= $month ?></a></li>
            <?php endforeach ?>
        </ul>
    <?php endif ?>
    </aside>
<?php endif ?>

</body>
</html>