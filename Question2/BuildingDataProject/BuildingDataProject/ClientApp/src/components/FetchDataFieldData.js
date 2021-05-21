import React, { Component } from 'react';

export class FetchDataFieldData extends Component {
    static displayName = FetchDataFieldData.name;

    constructor(props) {
        super(props);
        this.state = { dataFields: [], loading: true };
    }

    componentDidMount() {
        this.populateDataFieldData();
    }

    static renderDataFieldsTable(dataFields) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {dataFields.data.map(dataField =>
                        <tr key={dataField.id}>
                            <td>{dataField.id}</td>
                            <td>{dataField.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchDataFieldData.renderDataFieldsTable(this.state.dataFields);

        return (
            <div>
                <h1 id="tabelLabel" >DataField Data</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateDataFieldData() {
        const response = await fetch('api/dataField/getdataFields');
        const data = await response.json();
        console.log(data);
        console.log(data.data);
        this.setState({ dataFields: data, loading: false });
    }
}
