import renderCustomerReport from './reportComponents/renderCustomerReport'
import renderStoresReport from './reportComponents/renderCustomerReport'
import renderHome from './reportComponents/renderHome'

import React, { Component } from 'react';

const url = 'https://localhost:5001/Tasks';

export default class Reports extends Component {
    static displayName = Reports.name;

    constructor(props) {
        super(props);
        this.state = { ApiData: [], loading: true, view: "Home"};

        
    }

    componentDidMount() {
        console.log(this.state.view)
        this.fetchApiData();
    }

    render() {
        if (!this.state.loading) {
            if (this.props.tab === "customerReport") {
                
                return (

                    <div>
                        <h1 id="tableLabel" >Customer Report</h1>
                        {renderCustomerReport(this.state.ApiData)}
                    </div>
                );
            }

            else if (this.props.tab === "storesReport") {
                console.log(this.App.tab)
                return (
                    <div>
                        <h1 id="tableLabel" >Store Report</h1>
                        {renderStoresReport(this.state.ApiData)}
                    </div>
                );
            }
            else {
                console.log("super.props " + super.props)
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
        let response = await fetch(url);
        let data = await response.json();
        //data = JSON.parse(data);
        console.log(data);
        console.log(this.loading);
        this.setState({ ApiData: data, loading: false });
    }

}
