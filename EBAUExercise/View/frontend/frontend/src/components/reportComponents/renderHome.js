import React, { Component } from "react";

const API = "https://localhost:5001/";

export default class renderHome extends Component {
  constructor(props) {
    super(props);
    this.state = { ApiData: [], loading: true };
  }

  async fetchApiData() {
    let response = await fetch(API + "tasks");
    let data = await response.json();
    //data = JSON.parse(data);
    this.setState({ ApiData: data, loading: false });
  }

  componentDidMount() {
    this.fetchApiData();
  }

  render() {
    return (
      <div>
        <h1 id="tableLabel">IOC Exercise Report</h1>

        <p>Hello. The current count is {this.state.ApiData.count}.</p>
      </div>
    );
  }
}
