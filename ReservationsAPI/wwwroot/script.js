const reservationText = document.getElementById('reservations');
const sandbox = document.getElementById('sandbox');

const GetReservations = async () => {
  let response = await (
    await fetch('https://localhost:5001/reservations')
  ).json();
  let data = JSON.stringify(response);
  data = JSON.parse(data);
  reservationText.innerHTML = data
    .map((reservation) => {
      return `<ul> <li>ID: ${reservation.id}</li> <li>Customer Name: ${reservation.customerName}</li> <li>Time Requested: ${reservation.timeRequested}</li> <li>Restuarant: ${reservation.restaurant}</li> </ul>`;
    })
    .join('');
};

const ToggleColor = () => {
  sandbox.style.backgroundColor = `${GetRandomColor()}`;
};

const GetRandomColor = () => {
  var letters = '0123456789ABCDEF';
  var color = '#';
  for (var i = 0; i < 6; i++) {
    color += letters[Math.floor(Math.random() * 16)];
  }
  return color;
};
