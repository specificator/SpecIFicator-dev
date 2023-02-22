# SpecIFicator-dev
[![SpecIFictor Development Integration Build](https://github.com/oalt/SpecIFicator-dev/actions/workflows/specificator-integration-dev-build.yml/badge.svg)](https://github.com/oalt/SpecIFicator-dev/actions/workflows/specificator-integration-dev-build.yml)

[![Build backend and push Docker](https://github.com/oalt/SpecIFicator-dev/actions/workflows/backend-docker-build.yml/badge.svg)](https://github.com/oalt/SpecIFicator-dev/actions/workflows/backend-docker-build.yml)

[![Build frontend snapshot](https://github.com/oalt/SpecIFicator-dev/actions/workflows/frontend-publish-snapshot.yml/badge.svg)](https://github.com/oalt/SpecIFicator-dev/actions/workflows/frontend-publish-snapshot.yml)

Helper integration repository for SpecIFicator frontend and backend development.

SpecIFicator is a reference implementation for the [Specification Integration Facility (SpecIF)](https://github.com/GfSE/SpecIF) standard. 

# Setup development environment

The code is developed using Visual Studio 2022 and .NET 6.0. There are two different solution files (.sln) inside the `src/` folder for frontend and backend development:

* `SpecIFicator.Frontend-dev.sln` for frontend development
* `SpecIF_Backend-dev.sln` for backend (SpecIF microservice) development

## Submodules
The repository is organized with Git submodules referencing other repositories. This is done, because then it is possible to commit changes in different library projects seperately. 

**When you clone this repository, ensure that you also checkout and initialize the submodules!**
