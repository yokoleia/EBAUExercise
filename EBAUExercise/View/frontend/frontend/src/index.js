import { createRoot } from "react-dom/client";
import "./index.css";
import App from "./App.js";
import "bootstrap/dist/css/bootstrap.css";
import { BrowserRouter } from "react-router-dom";
import NavBar from "./components/navbar.js";


const container = document.getElementById("root");

const root = createRoot(container);
  root.render(
    <BrowserRouter>
      <NavBar />
      <App />
    </BrowserRouter>
  );