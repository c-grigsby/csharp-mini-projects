const statusButtons = document.querySelectorAll('input[name="status"]');
const newStatusButtons = document.querySelectorAll('input[name="edit-status"]');

const uri = '/api/todoitems';
let todos = [];

function getItems() {
  fetch(uri)
    .then((response) => response.json())
    .then((data) => _displayItems(data))
    .catch((error) => console.error('Unable to get items.', error));
}

function addItem() {
  const addNameTextbox = document.getElementById('add-name');
  const personAssignedTextbox = document.getElementById('person-assigned');
  const prioritySelection = document.getElementById('priority-select');

  let selectedStatus;
  statusButtons.forEach((radioButton) => {
    if (radioButton.checked) {
      selectedStatus = radioButton.value;
    }
  });
  if (!selectedStatus) selectedStatus = 'Not Started';

  const item = {
    status: selectedStatus,
    name: addNameTextbox.value.trim(),
    personAssigned: personAssignedTextbox.value.trim(),
    priority: prioritySelection.value,
  };

  fetch(uri, {
    method: 'POST',
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(item),
  })
    .then((response) => response.json())
    .then(() => {
      getItems();
      addNameTextbox.value = '';
    })
    .catch((error) => console.error('Unable to add item.', error));

  statusButtons.forEach((radioButton) => {
    if (radioButton.checked) {
      radioButton.checked = false;
    }
  });
  personAssignedTextbox.value = personAssignedTextbox.ariaPlaceholder;
  prioritySelection.selectedIndex = 0;
}

function deleteItem(id) {
  fetch(`${uri}/${id}`, {
    method: 'DELETE',
  })
    .then(() => getItems())
    .catch((error) => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
  const item = todos.find((item) => item.id === id);

  document.getElementById('edit-name').value = item.name;
  document.getElementById('edit-person').value = item.personAssigned;
  document.getElementById('edit-priority-select').value = item.priority;
  document.getElementById('edit-id').value = item.id;
  document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
  const itemId = document.getElementById('edit-id').value;

  let selectedStatus;
  newStatusButtons.forEach((radioButton) => {
    if (radioButton.checked) {
      selectedStatus = radioButton.value;
    }
  });
  if (!selectedStatus) selectedStatus = 'Not Started';

  const item = {
    id: parseInt(itemId, 10),
    name: document.getElementById('edit-name').value.trim(),
    status: selectedStatus,
    personAssigned: document.getElementById('edit-person').value.trim(),
    priority: document.getElementById('edit-priority-select').value,
  };

  fetch(`${uri}/${itemId}`, {
    method: 'PUT',
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(item),
  })
    .then(() => getItems())
    .catch((error) => console.error('Unable to update item.', error));

  closeInput();
  newStatusButtons.forEach((radioButton) => {
    if (radioButton.checked) {
      radioButton.checked = false;
    }
  });
  return false;
}

function closeInput() {
  document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
  const name = itemCount === 1 ? 'to-do' : 'to-dos';

  document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
  const tBody = document.getElementById('todos');
  tBody.innerHTML = '';

  _displayCount(data.length);

  const button = document.createElement('button');

  data.forEach((item) => {
    let statusDisplay = document.createElement('div');
    let personAssignedDisplay = document.createElement('div');
    let priorityLevelDisplay = document.createElement('div');

    let editButton = button.cloneNode(false);
    editButton.innerText = 'Edit';
    editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

    let deleteButton = button.cloneNode(false);
    deleteButton.innerText = 'Delete';
    deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

    let tr = tBody.insertRow();

    let td1 = tr.insertCell(0);
    td1.appendChild(statusDisplay);
    let text = document.createTextNode(item.status);
    td1.appendChild(text);

    let td2 = tr.insertCell(1);
    let textNode = document.createTextNode(item.name);
    td2.appendChild(textNode);

    let td3 = tr.insertCell(2);
    td3.appendChild(personAssignedDisplay);
    let personAssigned = document.createTextNode(item.personAssigned);
    td3.appendChild(personAssigned);

    let td4 = tr.insertCell(3);
    td4.appendChild(priorityLevelDisplay);
    let priorityLevel = document.createTextNode(item.priority);
    td4.appendChild(priorityLevel);

    let td5 = tr.insertCell(4);
    td5.appendChild(editButton);

    let td6 = tr.insertCell(5);
    td6.appendChild(deleteButton);
  });

  todos = data;
}
