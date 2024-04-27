const http = require("http");
const html = `
  <!DOCTYPE html>
  <html>
    <body style="margin:1em;">
      <h1>Donnees pour Nids de poule</h1>
    </body>
  </html>`;

const result = 'coordonnees: {45.422718, -75.741300}, date: 2024-04-27 14:27'

const requestHandler = (req, res) => {
    if (req.url == "/data") return res.end(result);
    if (req.url == "/") return res.end(html);
    res.writeHeader(404).end("Not found!");
};

http
    .createServer(requestHandler)
    .listen(8080, () => console.log("http://localhost:8080/"));