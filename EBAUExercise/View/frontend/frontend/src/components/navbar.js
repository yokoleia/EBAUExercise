import React, { useState } from "react";
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
// sample with useState
const NavigationBar = (props) => {
        
        const [isOpen, setIsOpen] = useState(false);

        const toggle = () => setIsOpen(!isOpen);

        
        
        return (
                <div>
                        <Navbar color="dark" dark expand="md">
                                <NavbarBrand style={{ color: "#ffa499" }} href="/">
                                        EBAUExercise V1
                                </NavbarBrand>
                                <NavbarToggler onClick={toggle} />
                                <Collapse isOpen={isOpen} navbar>
                                        <Nav className="mr-auto" navbar>
                                                <NavItem>
                                                        <NavLink href="/">Home</NavLink>
                                                </NavItem>
                                                <UncontrolledDropdown nav inNavbar>
                                                        <DropdownToggle nav caret>
                                                                Reports
                                                        </DropdownToggle>
                                                        <DropdownMenu>
                                                                <DropdownItem onClick={() => this.setState({ count: this.state.count + 1 })}>
                                                                        Customer Report
                                                                </DropdownItem>
                                                                <DropdownItem>
                                                                        Store Report
                                                                </DropdownItem>
                                                                
                                                        </DropdownMenu>
                                                </UncontrolledDropdown>
                                        </Nav>
                                        
                                </Collapse>
                        </Navbar>
                </div>
        );
};
export default NavigationBar;
