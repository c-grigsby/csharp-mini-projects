'use strict';

const reservationText = document.getElementById('reservations');
const sandbox = document.getElementById('sandbox');
const loadingSpinner1 = document.getElementById('preloader_1');
const getAllReservationsHeader = document.getElementById(
  'all_reservations_header'
);

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

  reservationText.innerHTML = data
    .map((reservation) => {
      return `ID: ${reservation.id}<br/> Customer Name: ${reservation.customerName}<br/> Time Requested: ${reservation.timeRequested}<br/> Restuarant: ${reservation.restaurant}<br/><br/>`;
    })
    .join('');
};

const toggleColor = () => {
  sandbox.style.backgroundColor = `${getRandomColor()}`;
};

const getRandomColor = () => {
  const letters = '0123456789ABCDEF';
  let color = '#';
  for (let i = 0; i < 6; i++) {
    color += letters[Math.floor(Math.random() * 16)];
  }
  return color;
};
