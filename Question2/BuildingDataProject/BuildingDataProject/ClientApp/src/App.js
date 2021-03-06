import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchBuildingData } from './components/FetchBuildingData';
import { FetchObjectData } from './components/FetchObjectData';
import { FetchDataFieldData } from './components/FetchDataFieldData';
import { FetchReadingData } from './components/FetchReadingData';
import { Counter } from './components/Counter';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetch-building-data' component={FetchBuildingData} />
            <Route path='/fetch-object-data' component={FetchObjectData} />
            <Route path='/fetch-datafield-data' component={FetchDataFieldData} />
            <Route path='/fetch-reading-data' component={FetchReadingData} />
      </Layout>
    );
  }
}
