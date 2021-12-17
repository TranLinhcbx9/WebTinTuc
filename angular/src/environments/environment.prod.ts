import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'WebTinTuc',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44322',
    redirectUri: baseUrl,
    clientId: 'WebTinTuc_App',
    responseType: 'code',
    scope: 'offline_access WebTinTuc',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44322',
      rootNamespace: 'WebTinTuc',
    },
  },
} as Environment;
