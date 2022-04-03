export default function renderCustomerReport(ApiData) {
        return (
                <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                                <tr>
                                        <th>Customer ID</th>
                                        <th>Number of Orders</th>
                                        <th>Cost of Orders</th>
                                </tr>
                        </thead>
                        <tbody>
                                {ApiData.customerReport.map(customerReport =>
                                        <tr key={customerReport.customerId}>
                                                <td>{customerReport.customerId}</td>
                                                <td>{customerReport.orderCount}</td>
                                                <td>${customerReport.orderTotal}</td>
                                        </tr>
                                )}
                        </tbody>
                </table>
        );
}