import renderCustomerReport from './reportComponents/renderCustomerReport'
import renderStoresReport from './reportComponents/renderStoresReport'
import renderHome from './reportComponents/renderHome'

import React, { Component } from 'react';

const apiurl = 'https://localhost:5001/Tasks';

export default class Reports extends Component {
    static displayName = Reports.name;

    constructor(props) {
        super(props);
        this.state = { ApiData: [], loading: true};

        
    }

    componentDidMount() {
        this.fetchApiData();
    }

    render() {
        if (!this.state.loading) {
            if (this.props.view === "customerReport") {
                
                return (
                    <div>
                        <h1 id="tableLabel" >Customer Report</h1>
                        {renderCustomerReport(this.state.ApiData)}
                    </div>
                );
            }

            else if (this.props.view === "storesReport") {
                
                return (
                    <div>
                        <h1 id="tableLabel" >Store Report</h1>
                        {renderStoresReport(this.state.ApiData)}
                    </div>
                );
            }
            else if (this.props.view === "home") {
                return (
                    
                    <div>

                        <h1 id="tableLabel" >IOC Exercise Report</h1>
                        {renderHome(this.state.ApiData)}
                    </div>
                )
            }
        }
    }

    async fetchApiData() {
        let response = await fetch(apiurl);
        let data = await response.json();
        //data = JSON.parse(data);
        this.setState({ ApiData: data, loading: false });
    }

}
