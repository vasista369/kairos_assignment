
let mockData = [
];
var url = "http://localhost:5000/api/items";
function fetchData() {

    fetch(url, {
        method: "GET"
    })
        .then(response => response.json())
        .then(result => {
            console.log("GET request response:", result);
            mockData = result
            generateItemList(mockData);
        })
        .catch(error => {
            console.log("GET request failed:", error);
        });
}

function generateItemList(data) {
    const itemList = document.getElementById('itemList');
    itemList.innerHTML = ''; // Clear the list first
    data.forEach(item => {
        const li = document.createElement('li');
        li.innerHTML = `
                                <h2 style="margin-left: 80px;">${item.name}</h2>
                                <h2 style="margin-left: 415px;">${item.company}</h2>
                            `;
        itemList.appendChild(li);
    });
}

function addItem() {
    const itemNameInput = document.getElementById('itemName');
    const itemDescriptionInput = document.getElementById('itemDescription');

    const itemName = itemNameInput.value.trim();
    const itemDescription = itemDescriptionInput.value.trim();

    //if (itemName === '' || itemDescription === '') {
    //    alert('Please fill out all fields.ddjjjjjnwdkjcsnkkjnjj');
    //    return;
    //}

    const newItem = {
        name: itemName,
        Company: itemDescription
    };
    console.log("newItem::", newItem)
    fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(newItem)
    })
        .then(response => response.json())
        .then(result => {
            console.log("POST request successful:", result);
        })
        .catch(error => {
            console.log("POST request failed:", error);
        });


    //console.log(JSON.stringify(newItem))
    mockData.push(newItem);
    generateItemList(mockData);

    //Clear the form
    itemNameInput.value = '';
    itemDescriptionInput.value = '';
}

fetchData()

// Get the form element and attach the addItem function to its submit event
const addItemForm = document.getElementById('addItemForm');
addItemForm.addEventListener('submit', function (event) {
    event.preventDefault();
    addItem();
});