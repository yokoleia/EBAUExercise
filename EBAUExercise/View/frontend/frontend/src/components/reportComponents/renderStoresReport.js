import React, { Component } from "react";

const API = "https://localhost:5001/";

export default class renderStoresReport extends Component {
  constructor(props) {
    super(props);
    this.state = { ApiData: [], loading: true };
  }

  async fetchApiData() {
    let response = await fetch(API + "storesReport");
    let data = await response.json();
    //data = JSON.parse(data);
    this.setState({ ApiData: data, loading: false });
  }

  componentDidMount() {
    this.fetchApiData();
  }

  render() {
    if (!this.state.loading) {
      return (
        <div>
          <h1 id="tableLabel">Store Report</h1>
          <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
              <tr>
                <th>Order Date</th>
                <th>Number of Orders</th>
                <th>Total Orders</th>
              </tr>
            </thead>
            <tbody>
              {this.state.ApiData.storesReport.map((storesReport) => (
                <tr key={storesReport.orderDate}>
                  <td>{storesReport.orderDate.split("T")[0]}</td>
                  <td>{storesReport.orderCount}</td>
                  <td>${Number(storesReport.orderTotal).toFixed(2)}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      );
    }
  }
}
