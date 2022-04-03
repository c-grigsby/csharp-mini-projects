'use strict';

const reservationText = document.getElementById('reservations');
const reservationByNameText = document.getElementById('reservations_byName');
const sandbox = document.getElementById('sandbox');
const loadingSpinner1 = document.getElementById('preloader_1');
const loadingSpinner2 = document.getElementById('preloader_2');
const getAllReservationsHeader = document.getElementById(
  'all_reservations_header'
);
const getReservationsByNameHeader = document.getElementById(
  'getByName_reservations_header'
);
const customerNameInput = document.getElementById('customer_name_input');
const customerNameLabel = document.getElementById('customer_name_label');

const getReservations = async () => {
  reservationText.innerHTML = '';
  getAllReservationsHeader.style.visibility = 'hidden';
  loadingSpinner1.style.display = 'block';

  let response = await (
    await fetch('https://localhost:5001/reservations')
  ).json();
  let data = JSON.stringify(response);
  data = JSON.parse(data);

  loadingSpinner1.style.display = 'none';
  getAllReservationsHeader.style.visibility = 'visible';

  if (data.length != 0) {
    reservationText.innerHTML = data
      .map((reservation) => {
        return `ID: ${reservation.id}<br/> Customer Name: ${reservation.customerName}<br/> Time Requested: ${reservation.timeRequested}<br/> Restuarant: ${reservation.restaurant}<br/><br/>`;
      })
      .join('');
  } else {
    reservationByNameText.innerHTML = `<p style="text-align:center">Hmm, no reservations found</p>`;
  }
};

const getReservationsByName = async () => {
  reservationByNameText.innerHTML = '';
  getReservationsByNameHeader.style.visibility = 'hidden';
  customerNameInput.style.visibility = 'hidden';
  customerNameLabel.style.visibility = 'hidden';
  loadingSpinner2.style.display = 'block';

  const customerName = customerNameInput.value;
  let response = await (
    await fetch(
      `https://localhost:5001/reservations/search?name=${customerName}`
    )
  ).json();
  let data = JSON.stringify(response);
  data = JSON.parse(data);

  loadingSpinner2.style.display = 'none';
  getReservationsByNameHeader.style.visibility = 'visible';
  customerNameLabel.style.visibility = 'visible';
  customerNameInput.style.visibility = 'visible';

  if (data.length != 0) {
    reservationByNameText.innerHTML = data
      .map((reservation) => {
        return `ID: ${reservation.id}<br/> Customer Name: ${reservation.customerName}<br/> Time Requested: ${reservation.timeRequested}<br/> Restuarant: ${reservation.restaurant}<br/><br/>`;
      })
      .join('');
  } else {
    reservationByNameText.innerHTML = `<p style="text-align:center">Hmm, no reservations found for customer</p>`;
  }
};

const toggleColor = () => {
  sandbox.style.backgroundColor = `${getRandomColor()}`;
};

const getRandomColor = () => {
  var letters = '0123456789ABCDEF';
  var color = '#';
  for (var i = 0; i < 6; i++) {
    color += letters[Math.floor(Math.random() * 16)];
  }
  return color;
};
