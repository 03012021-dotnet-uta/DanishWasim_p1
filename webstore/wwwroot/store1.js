let productsContainer = document.getElementById("inventory-wrap");

fetch('/goods/1', {
  method: 'GET',
  headers: {
    'Accept': 'application/json',
    'Content-Type':'application/json'
  },
  body:JSON.stringify(userData)
  })