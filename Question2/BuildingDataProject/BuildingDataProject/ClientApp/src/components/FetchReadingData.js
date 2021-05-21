import React, { Component } from 'react';

export class FetchReadingData extends Component {
    static displayName = FetchReadingData.name;

    constructor(props) {
        super(props);
        this.state = { readings: [], loading: true };
    }

    componentDidMount() {
        this.populateReadingData();
    }

    static renderReadingsTable(readings) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Value</th>
                        <th>TimeStamp</th>
                    </tr>
                </thead>
                <tbody>
                    {readings.data.map(reading =>
                        <tr key={reading.id}>
                            <td>{reading.id}</td>
                            <td>{reading.value}</td>
                            <td>{reading.timestamp}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchReadingData.renderReadingsTable(this.state.readings);

        return (
            <div>
                <h1 id="tabelLabel" >Reading Data</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateReadingData() {
        const response = await fetch('api/reading/getreadings');
        const data = await response.json();
        console.log(data);
        console.log(data.data);
        this.setState({ readings: data, loading: false });
    }
}
