import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import React,{ Component} from 'react';
import NavBar from "./components/navbar.js";
import Reports from "./components/reports"



export default class App extends Component {
  static displayName = App.name;
  constructor(props) {
    super(props);
    this.state = { view: "home" };
    this.updateView = this.updateView.bind(this);


  }

  updateView(currView) {
    this.setState({ view: currView });
  }


  render()
  {
    
    return(
    <>
        <NavBar updateView={this.updateView}/>
        <Reports updateView={this.updateView} view={this.state.view}/>
    </>
  )
    }
}