import React, { Component } from 'react';

export class FetchBuildingData extends Component {
  static displayName = FetchBuildingData.name;

  constructor(props) {
    super(props);
    this.state = { buildings: [], loading: true };
  }

  componentDidMount() {
    this.populateBuildingData();
  }

  static renderBuildingsTable(buildings) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Location</th>
          </tr>
        </thead>
            <tbody>
           {buildings.data.map(building =>
            <tr key={building.id}>
              <td>{building.id}</td>
              <td>{building.name}</td>
              <td>{building.location}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
        ? <p><em>Loading...</em></p>
        : FetchBuildingData.renderBuildingsTable(this.state.buildings);

    return (
      <div>
        <h1 id="tabelLabel" >Building Data</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateBuildingData() {
    const response = await fetch('api/building/getbuildings');
      const data = await response.json();
      console.log(data);
      console.log(data.data);
      this.setState({ buildings: data, loading: false });
  }
}
