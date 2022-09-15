import React, { Component } from 'react';


export class Student extends Component {

    constructor(props) {
        super(props);

        this.state = {

            Students: []

        }
    }

    refreshList() {

        fetch('https://localhost:7020/api/studentmanage')
            .then(response => response.json())
            .then(data => {
                this.setState({ Students: data });
            });
    }

    componentDidMount() {
        this.refreshList();
    }

    /* componentDidMount() {
         axios.get(`https://localhost:7004/api`)
             .then(res => {
                 const Students = res.data;
                 this.setState({ Students });
             })
     } */

    render() {
        const {
            Students
        } = this.state;

        return (
            <div>
                <h3>This is Student page</h3>

                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th>
                                Id
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Age
                            </th>
                            <th>
                                PhoneNumber
                            </th>
                            <th>
                                Address
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        {Students.map(stu =>
                            <tr key={stu.Id}>
                                <td>{stu.Id}</td>
                                <td>{stu.Name}</td>
                                <td>{stu.age}</td>
                                <td>{stu.PhoneNumber}</td>
                                <td>{stu.Address}</td>
                                <td>
                                </td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        )
    }
}