let productsContainer = document.getElementById("inventory-wrap");

fetch('/api/meme/stores', {
  method: 'GET',
  headers: {
    'Accept': 'application/json',
    'Content-Type':'application/json'
  },
  // body:JSON.stringify(userData)
  })
  .then(res => {
    return res.text();// extact the response body as text
  })
  .then(text => {
    // insert the image tag to the image div.
    const html = `${text}`;
    productsContainer.innerHTML = html;
  })
  .catch(err => console.error(err));