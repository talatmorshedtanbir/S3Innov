import React, { Component } from 'react';

export class FetchObjectData extends Component {
    static displayName = FetchObjectData.name;

    constructor(props) {
        super(props);
        this.state = { objects: [], loading: true };
    }

    componentDidMount() {
        this.populateObjectData();
    }

    static renderObjectsTable(objects) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {objects.data.map(object =>
                        <tr key={object.id}>
                            <td>{object.id}</td>
                            <td>{object.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchObjectData.renderObjectsTable(this.state.objects);

        return (
            <div>
                <h1 id="tabelLabel" >Object Data</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateObjectData() {
        const response = await fetch('api/object/getobjects');
        const data = await response.json();
        console.log(data);
        console.log(data.data);
        this.setState({ objects: data, loading: false });
    }
}
