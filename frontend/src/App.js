import * as React from "react";
import { Routes, Route } from "react-router-dom";
import "./App.css";
import RenderCustomerReport from "./components/reportComponents/renderCustomerReport";
import RenderHome from "./components/reportComponents/renderHome";
import RenderStoresReport from "./components/reportComponents/renderStoresReport";

export default function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/" element={<RenderHome />} />
        <Route path="/customerReports" element={<RenderCustomerReport />} />
        <Route path="/storesReports" element={<RenderStoresReport />} />
      </Routes>
    </div>
  );
}
