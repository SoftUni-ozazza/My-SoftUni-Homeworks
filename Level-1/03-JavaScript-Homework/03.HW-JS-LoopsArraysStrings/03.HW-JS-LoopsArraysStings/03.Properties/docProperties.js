function displayProperties(value) {
    var properties = [];
    for (var prop in document) {
        properties.push(prop);
    }
    properties.sort();

    console.info(properties.join('\n'));
}

displayProperties(activeElement);
displayProperties(alinkColor);
displayProperties(all);

// not working, sorry