import React, { Component } from "react";
const API = "https://localhost:5001/";

export default class renderCustomerReport extends Component {
  constructor(props) {
    super(props);
    this.state = { ApiData: [], loading: true };
  }

  async fetchApiData() {
    let response = await fetch(API + "customerReport");
    let data = await response.json();
    console.log("fetch result: " + data);
    //data = JSON.parse(data);
    this.setState({ ApiData: data, loading: false });
  }

  componentDidMount() {
    this.fetchApiData(this.state.endpoint);
  }

  render() {
    if (!this.state.loading) {
      return (
        <div>
          <h1 id="tableLabel">Customer Report</h1>

          <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
              <tr>
                <th>Customer ID</th>
                <th>Number of Orders</th>
                <th>Cost of Orders</th>
              </tr>
            </thead>
            <tbody>
              {console.log(this.state.ApiData.customerReport)}
              {this.state.ApiData.customerReport.map((customerReport) => (
                <tr key={customerReport.customerId}>
                  <td>{customerReport.customerId}</td>
                  <td>{customerReport.orderCount}</td>
                  <td>${Number(customerReport.orderTotal).toFixed(2)}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      );
    }
  }
}
