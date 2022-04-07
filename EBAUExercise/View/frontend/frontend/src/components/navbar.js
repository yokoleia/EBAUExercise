import React, {Component} from "react";
import {
        Collapse,
        Navbar,
        NavbarToggler,
        NavbarBrand,
        Nav,
        NavItem,
        NavLink,
        UncontrolledDropdown,
        DropdownToggle,
        DropdownMenu,
        DropdownItem,

} from "reactstrap";




export default class NavigationBar extends Component {
               
        render() {
                return (
                <div>
                        <Navbar color="dark" dark expand="md">
                                <NavbarBrand style={{ color: "#ffa499" }} href="/">
                                        EBAUExercise V1
                                </NavbarBrand>
                                <NavbarToggler />
                                <Collapse navbar>
                                        <Nav className="mr-auto" navbar>
                                                <NavItem>
                                                        <NavLink onClick={() => this.props.updateView("home")
                                                        }>Home</NavLink>
                                                </NavItem>
                                                <UncontrolledDropdown nav inNavbar>
                                                        <DropdownToggle nav caret>
                                                                Reports
                                                        </DropdownToggle>
                                                        <DropdownMenu>
                                                                <DropdownItem onClick={() => this.props.updateView("customerReport")
                                                                }>
                                                                        Customer Report
                                                                </DropdownItem>
                                                                <DropdownItem onClick={() => this.props.updateView("storesReport")
                                                                        }>
                                                                        Store Report
                                                                </DropdownItem>

                                                        </DropdownMenu>
                                                </UncontrolledDropdown>
                                        </Nav>

                                </Collapse>
                        </Navbar>
                </div >
                )
        }             
        
};
