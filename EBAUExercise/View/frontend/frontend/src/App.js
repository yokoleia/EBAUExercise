import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import React,{ Component} from 'react';
import NavBar from "./components/navbar.js";
import Reports from "./components/reports"



export default class App extends Component {
  static displayName = App.name;
  constructor(props) {
    super(props);
    this.state = { view: "" };


  }

  
  
  render()
  {
    return(
    <>
      <NavBar view={this.state.view}/>
        <Reports view={this.state.view}/>
    </>
  )
    }

}
